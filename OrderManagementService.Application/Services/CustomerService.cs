using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Customer.Requests;
using OrderManagementService.Application.DTOs.Customer.Responses;
using OrderManagementService.Domain.Entities;

namespace OrderManagementService.Application.Services;

public sealed class CustomerService(IBaseRepository<Customer, long> customerRepository, IUnitOfWork unitOfWork) : ICustomerService
{
    private readonly IBaseRepository<Customer, long> _customerRepository = customerRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<OperationResult<long>> CreateAsync(CreateCustomerRequest request, CancellationToken cancellationToken = default)
    {
        var validationResult = Validate(request.FirstName, request.LastName, request.PhoneNumber);
        if (validationResult.IsFailure)
        {
            return OperationResult<long>.Failure(validationResult.Error);
        }

        var phoneNumber = request.PhoneNumber.Trim();

        var phoneExists = await _customerRepository.ExistAsync(customer => customer.PhoneNumber == phoneNumber, cancellationToken);

        if (phoneExists)
        {
            return OperationResult<long>.Failure(new Error("Customer.PhoneNumber.Duplicate", "مشتری دیگری با این شماره تلفن ثبت شده است."));
        }

        var customer = new Customer(request.FirstName.Trim(), request.LastName.Trim(), phoneNumber);

        await _customerRepository.AddAsync(customer, cancellationToken);



        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);


        if (commitResult.IsFailure)
        {
            return OperationResult<long>.Failure(commitResult.Error);

        }

        return OperationResult<long>.Success(customer.Id);
    }

    public async Task<OperationResult<CustomerResponse>> GetByIdAsync(long customerId, CancellationToken cancellationToken = default)
    {
        var customer = await _customerRepository.GetAsync(customer => customer.Id == customerId,
            customer => new CustomerResponse
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            },
            cancellationToken);

        if (customer is null)
        {
            return OperationResult<CustomerResponse>.Failure(new Error("Customer.NotFound", "مشتری موردنظر پیدا نشد."));

        }

        return OperationResult<CustomerResponse>.Success(customer);
    }

    public Task<OperationResult<IReadOnlyCollection<CustomerResponse>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyCollection<CustomerResponse> customers = _customerRepository
                .GetAll(predicate: null,
                    customer => new CustomerResponse
                    {
                        Id = customer.Id,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        PhoneNumber = customer.PhoneNumber,
                        CreatedAt = customer.CreatedAt,
                        UpdatedAt = customer.UpdatedAt
                    })
                .OrderBy(customer => customer.Id)
                .ToList()
                .AsReadOnly();

        return Task.FromResult(OperationResult<IReadOnlyCollection<CustomerResponse>>.Success(customers));
    }

    public async Task<OperationResult> UpdateAsync(long customerId, UpdateCustomerRequest request, CancellationToken cancellationToken = default)
    {
        var validationResult = Validate(request.FirstName, request.LastName, request.PhoneNumber);
        if (validationResult.IsFailure)
            return validationResult;

        var customer = await _customerRepository.GetAsync(customer => customer.Id == customerId, cancellationToken);
        if (customer is null)
            return OperationResult.Failure(new Error("Customer.NotFound", "مشتری موردنظر پیدا نشد."));
        var phoneNumber = request.PhoneNumber.Trim();

        var duplicatePhone = await _customerRepository.ExistAsync(
            o =>
                o.Id != customerId &&
                o.PhoneNumber == phoneNumber,
            cancellationToken);

        if (duplicatePhone)
        
            return OperationResult.Failure(new Error("Customer.PhoneNumber.Duplicate", "مشتری دیگری با این شماره تلفن ثبت شده است."));
        customer.Update(request.FirstName.Trim(), request.LastName.Trim(), phoneNumber);

        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
    }

    #region Private Method
    private static OperationResult Validate(string firstName, string lastName, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            return OperationResult.Failure(new Error("Customer.Name.Required", "نام و نام خانوادگی الزامی است."));


        if (string.IsNullOrWhiteSpace(phoneNumber))
            return OperationResult.Failure(new Error("Customer.PhoneNumber.Required", "شماره تلفن الزامی است."));
        if (phoneNumber.Trim().Length > 11)

            return OperationResult.Failure(new Error("Customer.PhoneNumber.Invalid", "شماره تلفن معتبر نیست."));

        return OperationResult.Success();
    }

    #endregion
}