using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(),new DatabaseLoggerService(), new FileLoggerService ()} ;

;           BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers);

            //esnafı burada örnekledim bu da bir yöntem aslında yukardaki implementasyonla aşağıdaki aynı
            basvuruManager.BasvuruYap(new EsnafKredisiManager() , new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService(), new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBİlgilendirmesiYap(krediler);

        }

    }
}
