# LinkedInAutomationProject


Automation Selenium Project overview:-

The automated Selenium project consist of the following classes: LinkedinTests,
PageActions,
BasicMethods,
Hooks, 
Validations and 
PageObjects.
The separation of code when writing automated tests is a good
practice because it provides easier and quicker updates of tests. In this example, all page specific methods are declared in one class(PageActions), all validations are defined in other class (Validations).The class BasicMethods contains the most common user actions that are not page specific. Finally, in the class LinkedinTests, all methods are reused and combined in several specific test scenarios.
The class PageObjects contains all hard-coded page elements values(names, ids etc.). So, if any change is made to the page HTML, updates need to be done only in the class that corresponds to that page,without modification in all tests where that page is used.






 

