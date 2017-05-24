using System.Threading.Tasks;
using System.Web.Http;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace CodeBlock.Bot.Engine.Controllers
{
    public class webhookController : ApiController
    {

        #region Properties

        private Api bot;
        private static ReplyKeyboardMarkup main_menu_key;
        string botToken = "Bot Token";

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        public webhookController()
        {
            bot = new Api(botToken);

            //تعریف کیبورد
            main_menu_key = new ReplyKeyboardMarkup
            {
                Keyboard = new KeyboardButton[][] { new KeyboardButton[] { "ارسال عکس" }, new KeyboardButton[] { "درباره", "راهنما" } },
                ResizeKeyboard = true,
                OneTimeKeyboard = true,
            };
        }


        #endregion


        /// <summary>
        /// متدی برای پاسخگویی به آپدیت های ربات
        /// </summary>
        public async Task<IHttpActionResult> Post(Update update)
        {
            var chatType = update.Message.Chat.Type;

            //ربات به آپدیت های گروههای چت پاسخی ندهد
            if (chatType != ChatType.Private)
            {
                return Ok();
            }

            var text = update.Message.Text;

            if (text != null && text.Contains("/start"))
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "سلام دوست من، ربات آماده ی پاسخگوییه", replyMarkup: main_menu_key);
            }
            else if (text != null && text.Contains("ارسال عکس"))
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "لطفا یه عکس ارسال کن", replyMarkup: main_menu_key);

            }
            else if (text != null && text.Contains("درباره"))
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "متن درباره ربات", replyMarkup: main_menu_key);

            }
            else if (text != null && text.Contains("راهنما"))
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "متن راهنمای ربات", replyMarkup: main_menu_key);

            }
            else if (text != null && text.Contains("راهنما"))
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "متن راهنمای ربات", replyMarkup: main_menu_key);

            }
            else if (update.Message.Photo!=null)//اگر عکسی ارسال شده
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "لطفا منتظر باش تا عکس ذخیره بشه", replyMarkup: main_menu_key);
                //save to server ...
            }
            else
            {
                await bot.SendTextMessage(chatId: update.Message.Chat.Id, text: "دستور ناشناخته!!!", replyMarkup: main_menu_key);
            }

            return Ok();
        }



        /// <summary>
        /// یک متد برای تست  سرویس
        /// </summary>
        public string Get()
        {
            return "Yes Its Work";
        }
    }
}
