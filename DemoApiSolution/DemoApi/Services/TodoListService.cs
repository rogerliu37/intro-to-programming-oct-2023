using Marten;

namespace DemoApi.Services;

public class TodoListService
{
	private readonly IDocumentSession _documentSession;

	public TodoListService(IDocumentSession documentSession)
	{
		_documentSession = documentSession;
	}

	public async Task<TodoItemCreated> CreateTodoItem(CreateToDoItem item)
	{
		var newItem = new TodoItemCreated(Guid.NewGuid(), item.Description, false);

		_documentSession.Store(newItem);
		// get all your work lined up.
		await _documentSession.SaveChangesAsync();
		return newItem;
	}

}


public record CreateToDoItem(string Description);

public record TodoItemCreated(Guid Id, string Description, bool Completed);