namespace Board.Host.API.Controllers
{/// <summary>
 /// Модель создания объявления
 /// </summary>
	public class CreatePostDto
	{
		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Дата создания.
		/// </summary>
		public string DayTime Creation Date { get; set; }
		
	}
}