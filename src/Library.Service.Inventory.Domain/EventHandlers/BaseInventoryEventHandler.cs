﻿using Library.Domain.Core;
using Library.Domain.Core.DataAccessor;
using Library.Domain.Core.Messaging;
using Library.Service.Inventory.Domain.DataAccessors;

namespace Library.Service.Inventory.Domain.EventHandlers
{
    public abstract class BaseInventoryEventHandler<T> : BaseEventHandler<T> where T : DomainEvent
    {
        protected IInventoryReportDataAccessor _reportDataAccessor = null;
        protected IDomainRepository _domainRepository = null;
        protected IEventPublisher _eventPublisher = null;

        public BaseInventoryEventHandler(IInventoryReportDataAccessor reportDataAccessor, ICommandTracker commandTracker, ILogger logger, IDomainRepository domainRepository, IEventPublisher eventPublisher) : base(commandTracker, logger)
        {
            _reportDataAccessor = reportDataAccessor;
            _domainRepository = domainRepository;
            _eventPublisher = eventPublisher;
        }
    }
}