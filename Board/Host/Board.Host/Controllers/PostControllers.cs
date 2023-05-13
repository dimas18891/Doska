using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Board.Contracts.Posts;

namespace Board.Host.API.Controllers;
/// <summary>
/// Контролер для работы с объявлениями.
/// </summary>
[ApiController]
[Route(template: "[controller]")]
public class PostsController : ControllerBase
	
{/// <summary>
 /// Инициализирует экхемпляр <see cref="PostsController"/>
 /// </summary>
 /// <param name="Logger">Сервис логирования.</param>
	private const string Message = $"(JsonConvert.Serializeobject(model))";
	private readonly ILogger<PostsController> _logger;
	private object cancellation;
	private object _postService;
	private object dto;

	public PostsController(ILogger<PostsController> logger)
	{
		_logger = logger;
	}
	[HttpGet(template: "get-posts")]
	public async Task<IActionResult> Get()
	{
		_logger.LogInformation(message: $"Запрос объявлений");

		return await Task.Run(Ok);

	}
	[HttpPost]

	public async Task<IActionResult> CreatePost([FromBody] CreatePostDto model)
{
		_logger.LogInformation(message: $"{JsonConvert.SerializeObject(model)}");
		var result = await _postService.AddPost(dto, cancellation);

		return await Task.Run(function:() => Created(uri:string.Empty, result));
	}


}				