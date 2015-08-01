using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using UniRitter.UniRitter2015.Models;
using UniRitter.UniRitter2015.Services;
using UniRitter.UniRitter2015.Services.Implementation;

namespace UniRitter.UniRitter2015.Controllers
{

    public class CommentController : BaseController<CommentModel>
    {
        private readonly IRepository<CommentModel> _repo;

        public CommentController(IRepository<CommentModel> repo)
            : base(repo)
        {
            _repo = repo;
        }
    }

}