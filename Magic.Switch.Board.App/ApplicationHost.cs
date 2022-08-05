namespace Magic.Switch.Board.App;

public class ApplicationHost : IHostedService
{
	private readonly ILogger<ApplicationHost> logger;

	public ApplicationHost(ILogger<ApplicationHost> logger) =>
		this.logger = logger;

	public async Task StartAsync(CancellationToken cancellationToken) =>
		await Task.CompletedTask;

	public async Task StopAsync(CancellationToken cancellationToken) =>
		await Task.CompletedTask;
}
