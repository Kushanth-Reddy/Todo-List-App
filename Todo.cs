using System.ComponentModel.DataAnnotations.Schema;

class Todo
{
    public string name;
    public Todo(string todoName)
    {
        name = todoName;
    }
}