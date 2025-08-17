using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Domain.Conference.Entities
{
    public class Conference
    {
        public int ConferenceId { get; private set; }
        public Guid PublicId { get; private set; }
        public string Title { get; private set; }
        public DateTimeOffset StartDate { get; private set; }
        public DateTimeOffset EndDate { get; private set; }
        
        private Conference()
        {            
        }

        public Conference(Guid publicId, DateTimeOffset startDate, DateTimeOffset endDate, string name)
        {
            PublicId = publicId;
            StartDate = startDate;
            EndDate = endDate;
            Title = name;
        }
    }
}
