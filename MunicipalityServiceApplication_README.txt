Municipality Citizen Issue Reporting Application

Introduction
This C# Windows Forms application allows residents to report municipal service issues in a user-friendly and seamless way. The application currently supports the Report Issues feature, 
with future functionality planned for Local Events and Announcements and Service Request Status.

Features
- Report Issues: Users can report issues by entering details such as the location, category, description, and attaching media files like images or documents.
- User Engagement: Dynamic messages or progress bars encourage active participation from users.
- Navigation: Simple and intuitive navigation for returning to the main menu.

Requirements
- .NET Framework 4.8 or higher
- Windows OS

 How to Compile and Run the Program

Step 1: Clone or Download the Repository
Clone this repository to your local machine using:

Alternatively, download the repository as a ZIP file and extract it to your local machine.

Step 2: Open the Project in Visual Studio
1. Open Visual Studio.
2. Click on `File` -> `Open` -> `Project/Solution`.
3. Navigate to the folder where the project was saved, and open the `.csproj` file.

Step 3: Build the Project
1. In Solution Explorer, right-click on the solution and select `Build Solution`.
2. Ensure there are no errors.

Step 4: Run the Program
1. Click `Start` or press `F5` to run the application.
2. The application will open with the Main Menu, where you can select the Report Issues task.

Usage Instructions

 Main Menu
- On start-up, the main menu presents three tasks:
  - Report Issues: This feature allows you to report municipal service issues.
  - Local Events and Announcements: Allows you to view and search local events and view announcements.
  - Service Request Status: (Still to be implemented)
  
Reporting an Issue
1. Select the Report Issues option from the main menu.
2. Fill out the form by:
   - Entering the location of the issue.
   - Selecting the appropriate category from the dropdown (e.g., Sanitation, Roads, Utilities).
   - Providing a detailed description in the Description Box.
   - Optionally attaching an image or document using the Attach Media button.
3. After filling in all fields, click Submit to send the report.
   - If any fields are left blank, the system will prompt you to complete the form.
4. Upon successful submission, a confirmation message will be displayed.

Navigation
- To return to the main menu, click the Back to Main Window button located on the Report Issues page.
--------------------------------------------------------------------------------------------------------------------------
Local Events and Announcements 

This feature allows users to view upcoming local events and important announcements in their community.

Viewing Local Events
1. Select the Local Events and Announcements option from the main menu.
2. The application will display a list of upcoming events, including the following details:
   - Event Name
   - Date
   - Category (e.g.Entertainment, Education and so on)
   
3. Search Filters:
   - Category Filter: Select a category (e.g.Entertainment, Education and so on) from the dropdown menu to filter events.
   - Date Filter: Select a specific date using the date picker to find events happening on that date.
   - Click the Search button to apply the filters.

4. Event Display:
   - Each event is displayed with its name, date, and category in a card-like format.
   - Events are colour-coded based on their category to help you easily distinguish between different types of events.

5. Navigation:
   - To return to the main menu, click the Back to Main Window button located at the bottom of the Local Events page.

 Viewing Announcements
1. Important municipal announcements are listed alongside local events.
2. Each announcement includes:
   - **Title**: The headline of the announcement.
   - **Description**: A brief description of the announcement.
   - **Date**: The date the announcement was made.

3. Announcements will be displayed in a list below the events section. Just like with events, you can easily scroll through to view them.


How to Compile and Run the Updated Program

Follow the same steps as previously outlined:

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Build the project.
4. Run the program.

Now, the Local Events and Announcements feature is fully implemented, allowing you to view events and announcements in addition to reporting municipal service issues.


