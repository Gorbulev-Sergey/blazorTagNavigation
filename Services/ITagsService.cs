using blazorTagNavigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorTagNavigation.Services
{
    public interface ITagsService
    {
        List<tag> getTags();
    }

    public class TagsService : ITagsService
    {
        private List<tag> tags = new List<tag>();

        public List<tag> getTags() => tags;

        public TagsService()
        {
            tags = new List<tag> {
                new tag{name="житие",description="Жития святых"},
                new tag{name="ветер",description="Ветер дует"},
                new tag{name="поездки",description="Поездки"},
                new tag{name="путешествия",description="Путешествия", bg_color=bootstrap_colors.warning, text_color=bootstrap_colors.white},
                new tag{name="погода",description="Погода хорошая"}
            };
        }
    }
}
