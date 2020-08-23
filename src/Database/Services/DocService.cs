using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDocs.Database
{
    public class DocService : Service<Doc>
    {
        public DocService(DocsContext context) : base(context)
        { }

        public Task<Doc> Get(string url) =>
            context
                .Set<Doc>()
                .FirstOrDefaultAsync(e => e.Url == url);
    }
}