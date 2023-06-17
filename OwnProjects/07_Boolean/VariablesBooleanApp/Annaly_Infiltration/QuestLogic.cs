using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annaly_Infiltration
{
    internal class QuestLogic
    {
        public bool CanFastAttack(bool knightIsAwake)
        {
            return !knightIsAwake;
        }
        public bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake || archerIsAwake || prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (!archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent && !archerIsAwake)
            {
                return true;
            }
            else if (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
