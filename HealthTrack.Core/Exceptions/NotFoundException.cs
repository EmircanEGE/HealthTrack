﻿namespace HealthTrack.Core.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string entityName, object key)
            : base($"{entityName} with id ({key}) not found)")
        {
        }
    }
}
