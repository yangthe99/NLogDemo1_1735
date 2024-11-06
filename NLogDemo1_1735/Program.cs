using NLog;

namespace NLogDemo1_1735
{
    internal class Program
    {
        // Logger 依據 NLog.config 設定的規則處理日誌訊息。
        // LogManager.GetCurrentClassLogger()會返回一個與當前類別名稱相對應的 Logger 物件。
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {

            logger.Info("這是一條 Info 訊息");
            logger.Error("這是一條 Error 訊息");

            Console.WriteLine("完成log");
        }
    }
}

// 當在 Program 中使用 LogManager.GetCurrentClassLogger() 取得 Logger 物件時
// 這個 Logger 的 名稱 默認會是 "Program"

// 預設情況下，不會在日誌內容中自動顯示 Program 這個名稱
// 除非在日誌的格式（layout）中顯式地加入 ${logger}