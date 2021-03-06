﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Objects.Beds;
using Sims3.Gameplay.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.ErrorTrapSpace.Dereferences
{
    public class DerefBunkBedBunk : Dereference<BunkBedBunk>
    {
        protected override DereferenceResult Perform(BunkBedBunk reference, FieldInfo field, List<ReferenceWrapper> objects)
        {
            if (Matches(reference, "BunkBed", field, objects))
            {
                Remove(ref reference.BunkBed);
                return DereferenceResult.End;
            }

            return DereferenceResult.Failure;
        }
    }
}
