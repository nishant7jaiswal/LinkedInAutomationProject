using OpenQA.Selenium;

namespace NUnit.TouchcoreTesting
{
    public static class PageObject
    {

    // Login screen objects
    public static By loginEmailInput = By.Id("username");
    public static By loginPassInput = By.Id("password");
    public static By loginButton = By.XPath("//button");
    public static By forgotPassLink = By.LinkText("Forgot password?");

    // Home screen objects
    public static By newsFeedElement = By.Id("ozfeed");
    public static By UsernameHome = By.XPath("//div[@class='profile-rail-card__actor-link t-16 t-black t-bold']");
        
        // Profile screen objects
    public static By fullNameElement = By.XPath("full-name");
    public static By localityElement = By.XPath("locality");
    public static By Profiledropdown = By.XPath("locality");
    public static By ProfileLinkMenu = By.XPath(".//*[@id='main-sitenav']/ul/li[2]/a");
    public static By editProfileLink = By.XPath("//li-icon[@aria-label='Edit Profile']");
    public static By addheadline = By.Id("topcard-headline");
    public static By saveProfile = By.XPath("//div[@class='pe-form-footer__actions display-flex justify-space-between']//button[text()='Save']");
    public static By selectindustry = By.XPath("//select[@id='topcard - industry']");
    public static By navProfilePhoto = By.Id("ember24");
    public static By logoutButton = By.Id("ember38");
    }
}
