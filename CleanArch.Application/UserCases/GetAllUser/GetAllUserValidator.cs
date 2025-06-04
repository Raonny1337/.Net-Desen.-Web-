using CleanArch.Application.UseCases.GetAllUser;
using FluentValidation;

namespace CleanArch.Application.UseCases.GetAllUser;

public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
{
    public GetAllUserValidator()
    {
        //sem validação    
    }
}