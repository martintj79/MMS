using MMS.Data.Models;
using MMS.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MMS.Web.Api
{
    public class MembersController : ApiController
    {
        private readonly IMemberService db;

        public MembersController(IMemberService db)
        {
            this.db = db;
        }

        public IEnumerable<Member> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
