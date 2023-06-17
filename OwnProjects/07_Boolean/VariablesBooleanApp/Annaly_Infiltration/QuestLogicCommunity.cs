using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annaly_Infiltration
{
    internal class QuestLogicCommunity
    {
        public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;
        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;
        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => !archerIsAwake && (!knightIsAwake && prisonerIsAwake || petDogIsPresent);
    }
}
