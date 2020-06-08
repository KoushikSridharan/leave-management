using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leave_management.Models;
using leave_management.Data;

namespace leave_management.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>();
            CreateMap<LeaveType, CreateDetailsTypeVM>();
            CreateMap<LeaveAllocation, LeaveAllocationVM>();
            CreateMap<LeaveHistory, LeaveHistoryVM>();
            CreateMap<Employee, EmployeeVM>();
        }
        
        
        
        
    
    
    
    }
}
