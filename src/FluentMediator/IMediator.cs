namespace FluentMediator
{
    public interface IMediator : IPipelineMediator, IAsyncPipelineMediator, ICancellablePipelineMediator
    {
        GetService GetService { get; }
        PipelineBuilder<Request> When<Request>();
    }
}