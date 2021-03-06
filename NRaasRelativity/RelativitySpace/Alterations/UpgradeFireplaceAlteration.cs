﻿using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems.Children;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Careers;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.EventSystem;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Objects.Fireplaces;
using Sims3.Gameplay.Pools;
using Sims3.Gameplay.Skills;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.UI;
using Sims3.UI.CAS;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.RelativitySpace.Alterations
{
    public class UpgradeFireplaceAlteration : AlterationList
    {
        public UpgradeFireplaceAlteration(Fireplace.Tuning tuning, float factor)
        {
            Add(new UpgradeAlteration(tuning.UpgradeAutoLight, factor));
            Add(new UpgradeAlteration(tuning.UpgradeChangeColor, factor));
            Add(new UpgradeAlteration(tuning.UpgradeFireproof, factor));
        }
    }
}
