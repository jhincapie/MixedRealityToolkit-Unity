﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Internal.EventDatum.Input;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem.Handlers
{
    /// <summary>
    /// Interface to implement to react to focus enter/exit.
    /// </summary>
    public interface IMixedRealityFocusHandler : IMixedRealityFocusChangedHandler
    {
        /// <summary>
        /// Does this object currently have focus by any <see cref="IMixedRealityPointer"/>?
        /// </summary>
        bool HasFocus { get; }

        /// <summary>
        /// Is Focus enabled for this <see cref="GameObject"/>?
        /// </summary>
        bool FocusEnabled { get; set; }

        /// <summary>
        /// The list of <see cref="IMixedRealityPointer"/>s that are currently focused on this <see cref="GameObject"/>
        /// </summary>
        List<IMixedRealityPointer> Focusers { get; }

        /// <summary>
        /// The Focus Enter event is raised on this <see cref="GameObject"/> whenever a <see cref="IMixedRealityPointer"/>'s focus enters this <see cref="GameObject"/>'s <see cref="Collider"/>.
        /// </summary>
        /// <param name="eventData"></param>
        void OnFocusEnter(FocusEventData eventData);

        /// <summary>
        /// The Focus Exit event is raised on this <see cref="GameObject"/> whenever a <see cref="IMixedRealityPointer"/>'s focus leaves this <see cref="GameObject"/>'s <see cref="Collider"/>.
        /// </summary>
        /// <param name="eventData"></param>
        void OnFocusExit(FocusEventData eventData);
    }
}