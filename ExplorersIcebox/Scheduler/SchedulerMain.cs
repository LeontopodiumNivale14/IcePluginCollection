using ExplorersIcebox.Enums;
using static ExplorersIcebox.Enums.IceBoxState;

namespace ExplorersIcebox.Scheduler
{
    internal static unsafe class SchedulerMain
    {
        internal static bool EnablePlugin()
        {
            State = Start;
            return true;
        }
        internal static bool DisablePlugin()
        {
            P.taskManager.Abort();
            P.navmesh.Stop();
            State = Idle;
            return true;
        }

        internal static IceBoxState State = Idle;

        internal static void Tick()
        {
            if (P.taskManager.NumQueuedTasks == 0 && State != Idle)
            {
                switch (State)
                {
                    case IceBoxState.Start:
                        break;
                    case IceBoxState.CheckSell:
                        break;
                    case IceBoxState.SellToNpc:
                        break;
                    case IceBoxState.RunRoute:
                        break;
                    default:
                        DisablePlugin();
                        break;
                }
            }
        }
    }
}
