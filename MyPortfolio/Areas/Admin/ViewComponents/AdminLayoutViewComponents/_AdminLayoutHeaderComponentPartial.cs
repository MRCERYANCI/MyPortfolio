﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
	public class _AdminLayoutHeaderComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
