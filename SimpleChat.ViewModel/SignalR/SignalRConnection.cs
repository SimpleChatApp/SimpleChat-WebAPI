﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SimpleChat.Core.ViewModel;

namespace SimpleChat.ViewModel.SignalR
{
    public record SignalRConnection : BaseVM<string>
    {
        public Guid UserId { get; set; }
        public Guid? GroupId { get; set; }
    }
}
