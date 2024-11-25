using System; // тут базовые штуки, без них всё упадёт, даже не пытайтесь
using System.Windows.Forms; // а это магия, чтобы можно было сделать окошко с кнопочками

public class Program : Form // это мой шедевр — приложение, которое решает задачки. Надеюсь
{
    TextBox input = new TextBox { Location = new System.Drawing.Point(10, 10), Width = 100 }; // поле для ввода — на передовой, принимает удар первым
    RadioButton rb1 = new RadioButton { Text = "x^2", Location = new System.Drawing.Point(10, 40) }; // первая радиокнопка. Классика. Квадрат числа.
    RadioButton rb2 = new RadioButton { Text = "2x+5", Location = new System.Drawing.Point(10, 70) }; // вторая кнопка. Для линейных фанатов.
    RadioButton rb3 = new RadioButton { Text = "sin(x)", Location = new System.Drawing.Point(10, 100) }; // третья радиокнопка. Это для тех, кто понимает тригонометрию.
    Button calcButton = new Button { Text = "Вычислить", Location = new System.Drawing.Point(10, 130) }; // центральная кнопка. Без неё ничего не двинется.
    Label result = new Label { Text = "Результат:", Location = new System.Drawing.Point(10, 160), AutoSize = true }; // лейбл. Надеюсь, он будет показывать только хорошие новости.

    public Program() // здесь начинается сборка. Всё как в конструкторе, только сложнее
    {
        calcButton.Click += (sender, e) =>
        {
            double x; // какая-то переменная. Наверное, число. Пусть будет x, звучит умно
            try
            {
                x = Convert.ToDouble(input.Text); // беру текст, превращаю в число. Если ввели "првиет", будет сюрприз
            }
            catch
            {
                result.Text = "Результат: Ошибка. Тут только числа. Без экспериментов."; // напоминание о правилах
                return;
            }

            if (rb1.Checked)
            {
                result.Text = "Результат: " + (x * x); // квадрат. Потому что x * x это красиво
            }
            else if (rb2.Checked)
            {
                result.Text = "Результат: " + (2 * x + 5); // простая формула. Даже скучно
            }
            else if (rb3.Checked)
            {
                result.Text = "Результат: " + Math.Sin(x); // синус. Если вы вдруг тригонометрический гений
            }
            else
            {
                result.Text = "Результат: Выберите что-нибудь. Это не тест на угадывание."; // когда всё сломалось
            }
        };

        Controls.AddRange(new Control[] { input, rb1, rb2, rb3, calcButton, result }); // всё добавляю на форму. Это как кухня: порядок важен, но бардак неизбежен
    }

    public static void Main() // тут всё начинается. Пора нажать F5 и молиться
    {
        Application.Run(new Program()); // запускаю приложение. Ура, оно работает (надеюсь)!
    }
}
