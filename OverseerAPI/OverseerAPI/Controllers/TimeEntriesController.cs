﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using OverseerAPI.Data.Interface;
using OverseerAPI.Data.Service;
using OverseerAPI.Models.TimeEntry;

namespace OverseerAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/TimeEntries")]
    public class TimeEntriesController : ApiController
    {
        private readonly ITimeEntryService _service;

        public TimeEntriesController()
            : this(new TimeEntryService())
        {

        }

        public TimeEntriesController(ITimeEntryService service)
        {
            this._service = service;
        }
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Route("Get")]
        // GET api/values
        public List<TimeEntry> Get()
        {
            return this._service.Get();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
