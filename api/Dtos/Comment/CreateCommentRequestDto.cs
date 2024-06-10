using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters")]
        [MaxLength(255, ErrorMessage = "Title can not be over 255 caracters")]
        public string Title { get; set; } = string.Empty;


        [Required]
        [MinLength(5, ErrorMessage = "Content must be 5 characters")]
        [MaxLength(255, ErrorMessage = "Content can not be over 255 caracters")]
        public string Content { get; set; } = string.Empty;
    }
}