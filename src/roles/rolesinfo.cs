using System;

class Roles {
    static void Main(string[] args) {
        private void InfoRoles {
            var Admin {
                CanAddTransportInfo = true;
                CanAddItemInfo = true;
                CanSeeLog = true;
                CanSeeDB = true;
                CanSeeWorkers = true;
                CanSeeItemLog = true;
                
            var Gruzchik {
                CanAddTransportInfo = true;
                CanAddItemInfo = true;
                CanSeeLog = true;
                CanSeeDB = true;
                CanSeeWorkers = false;
                CanSeeItemLog = false;
            }
            var Priem {
                CanAddTransportInfo = true;
                CanAddItemInfo = true;
                CanSeeLog = true;
                CanSeeDB = true;
                CanSeeWorkers = true;
                CanSeeItemLog = true;
            }
            Console.Writeine("Admin Can: " +  CanAddTransportInfo, CanAddItemInfo, CanSeeLog, CanSeeDB, CanSeeWorkers, CanSeeItemLog);
            Console.Writeine("Gruzchik Can: " +  CanAddTransportInfo, CanAddItemInfo, CanSeeLog, CanSeeDB, CanSeeWorkers, CanSeeItemLog);
            Console.Writeine("Priem Can: " +  CanAddTransportInfo, CanAddItemInfo, CanSeeLog, CanSeeDB, CanSeeWorkers, CanSeeItemLog);
        }
    }
}
