
namespace CrudBlazor.Shared.Wrapper;

public class Result
{
    public Result()
    {
        
    }
    public Result(bool succeeded, List<string>? message = default!)
    {
        Succeeded = succeeded;
        Message = message;
    }

    public bool Succeeded {get;set;}
    public List<string>? Message { get; set; }

    public static Result Fail()
    {
        return new Result(false);
    }
    public static Result Fail(string message)
    {
        return new Result(false, new List<string>(){ message});
    }
    public static Result Fail(List<string> messages)
    {
        return new Result(false, messages);
    }

    public static Result Sucess(string message)
    {
        return new Result(true, new List<string>(){ message});
    }
    public static Result Sucess(List<string> messages)
    {
        return new Result(true, messages);
    }
}

public class Result<T>:Result
{
    public T Data { get; set; } = default!;

    public new static Result<T> Fail(){
        return new Result<T>(){Succeeded = false, Message = new List<string>(){"❌"}};
    }
    public new static Result<T> Fail(string message){
        return new Result<T>(){Succeeded = false, Message = new List<string>(){message}};
    }
    public new static Result<T> Fail(List<string> messages){
        return new Result<T>(){Succeeded = false, Message = messages};
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(){
            Succeeded = true, 
            Message = new List<string>(){"👌"},
            Data = data
            };
    }
    public static Result<T> Success(T data, string message)
    {
        return new Result<T>(){
            Succeeded = true, 
            Message = new List<string>(){message},
            Data = data
            };
    }
    public static Result<T> Success(T data, List<string> messages)
    {
        return new Result<T>(){
            Succeeded = true, 
            Message = messages,
            Data = data
            };
    }
} 
