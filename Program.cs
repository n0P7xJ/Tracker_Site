using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

class Program
{
    static void Main()
    {
        // Ініціалізація FirefoxDriver
        using IWebDriver driver = new FirefoxDriver();

        // Переходимо на Google
        driver.Navigate().GoToUrl("https://www.google.com");

        // Знаходимо поле пошуку за атрибутом name="q"
        IWebElement searchBox = driver.FindElement(By.Name("q"));

        // Вводимо текст і відправляємо форму
        searchBox.SendKeys("Selenium C#");
        searchBox.Submit();

        // Трохи почекаємо, щоб побачити результат
        Console.ReadLine();

        // Закриваємо браузер
        driver.Quit();
    }
}
