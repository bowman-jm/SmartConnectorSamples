﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for SystemEventTypes.
    /// </summary>
    public static partial class SystemEventTypesExtensions
    {
            /// <summary>
            /// Returns all SystemEventType which fit the filter criteria supplied. All
            /// filter parameters are optional. SystemEventType will be ordered and paged
            /// as requested.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Filtered by Name.
            /// </param>
            /// <param name='orderBy'>
            /// SystemEventType will be returned in this order.  NameAscending by default.
            /// Possible values include: 'NameAscending', 'NameDescending'
            /// </param>
            /// <param name='take'>
            /// Number of SystemEventType that should be returned.  200 by default.
            /// </param>
            /// <param name='skip'>
            /// Number of SystemEventType that should be skipped before items are
            /// returned.  0 by default.
            /// </param>
            public static IList<SystemEventTypeModel> Retrieve(this ISystemEventTypes operations, string name = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?))
            {
                return Task.Factory.StartNew(s => ((ISystemEventTypes)s).RetrieveAsync(name, orderBy, take, skip), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all SystemEventType which fit the filter criteria supplied. All
            /// filter parameters are optional. SystemEventType will be ordered and paged
            /// as requested.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Filtered by Name.
            /// </param>
            /// <param name='orderBy'>
            /// SystemEventType will be returned in this order.  NameAscending by default.
            /// Possible values include: 'NameAscending', 'NameDescending'
            /// </param>
            /// <param name='take'>
            /// Number of SystemEventType that should be returned.  200 by default.
            /// </param>
            /// <param name='skip'>
            /// Number of SystemEventType that should be skipped before items are
            /// returned.  0 by default.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SystemEventTypeModel>> RetrieveAsync(this ISystemEventTypes operations, string name = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveWithHttpMessagesAsync(name, orderBy, take, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the SystemEventType with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the SystemEventType requested.  Must be double URL encoded.
            /// </param>
            public static SystemEventTypeModel RetrieveById(this ISystemEventTypes operations, string id)
            {
                return Task.Factory.StartNew(s => ((ISystemEventTypes)s).RetrieveByIdAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the SystemEventType with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the SystemEventType requested.  Must be double URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SystemEventTypeModel> RetrieveByIdAsync(this ISystemEventTypes operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Description property for the SystemEventType with the Id
            /// provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the SystemEventType whose Description property is to be returned.
            /// Must be double URL encoded.
            /// </param>
            public static string RetrieveDescription(this ISystemEventTypes operations, string id)
            {
                return Task.Factory.StartNew(s => ((ISystemEventTypes)s).RetrieveDescriptionAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Description property for the SystemEventType with the Id
            /// provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the SystemEventType whose Description property is to be returned.
            /// Must be double URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveDescriptionAsync(this ISystemEventTypes operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveDescriptionWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Name property for the SystemEventType with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the SystemEventType whose Name property is to be returned.  Must be
            /// double URL encoded.
            /// </param>
            public static string RetrieveName(this ISystemEventTypes operations, string id)
            {
                return Task.Factory.StartNew(s => ((ISystemEventTypes)s).RetrieveNameAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Name property for the SystemEventType with the Id provided.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the SystemEventType whose Name property is to be returned.  Must be
            /// double URL encoded.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RetrieveNameAsync(this ISystemEventTypes operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveNameWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
