using System;
using System.ComponentModel.DataAnnotations;

namespace GiriajCarModel.Models
{
	public class SearchModel
	{
		[Required]
		public string q { get; set; }
	}
}

