using FluentValidation;

namespace Todos.Applications.Handlers.Queries.GetTodo;

public class GetTodoQueryValidator : AbstractValidator<GetTodoQuery>
{
    public GetTodoQueryValidator()
    {
        RuleFor(e => e.TodoId).GreaterThan(0);
    }
}