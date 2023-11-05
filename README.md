<div id="top"></div>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/SAM-ITH/FitnessTracker">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Fitness Tracker</h3>

  <p align="center">
    Fitness Tracker is a fitness tracking and prediction tool for personal use. This tool will enable you to record your workouts and cheat meals, generate reports.this project has been done as a requirment to the 7SENG001C Enterprise Application Development module.
    <br />
    <a href="https://github.com/SAM-ITH/FitnessTracker"><strong>Course work file »</strong></a>
    <br />
    <br />
    <a href="https://github.com/SAM-ITH/FitnessTracker">View Demo</a>
    ·
    <a href="https://github.com/SAM-ITH/FitnessTracker/issues">Report Bug</a>
    ·
    <a href="https://github.com/SAM-ITH/FitnessTracker/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Requirments</a>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

![Product Name Screen Shot][product-screenshot]

- Main requirment for this project as follows 

The user must have the ability to add their weight followed by workouts and/or cheat meals for a given day. They may one-off or recurring. You should also provide a weekly view showing the workout and cheat meals for each day of the week.


<p align="right">(<a href="#top">back to top</a>)</p>

### Built With

* [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [WindowsForms](https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)


<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Functional Requirments

• User registration: Provide a mechanism for users to create an account to access the fitness tracking app.
• User profile: Allow users to input and update their information.
• Recording workouts – enable users to add details of their workouts.
• Recording cheat meals – allow users to log information about cheat meals.
• Daily tracking
• One off and recurring entries – allow users to input one-time or recurring workouts
and cheat melas.
• Report generation – generate reports summarising the recorded workouts and cheat
meals.
• Fitness prediction – predict the users future fitness status according to their workouts.
• Weekly view – display all the work outs and cheat meals regrading to the selected
week.

## Non-Functional Requirments

• User friendly interface
• Performance and responsiveness
• Reliability and availability
• Scalability

<p align="right">(<a href="#top">back to top</a>)</p>

## Domain Model for the system

![Domain model Screen Shot][domainmodel-image]

<!-- USAGE EXAMPLES -->
## Usage

A user wishes to calculate the interest required to return a future value for a fixed initial investment sum over a known period of time. E.g. A user wishes to know if they invest Rs.100,000 for 5 years, what interest rate would be required to return a future value of Rs.300,000.

A user wishes to calculate the length of time (number of compound payments) required to return a future value for a known fixed initial investment given a known interest rate.

E.g. A user wished to know how long it would be before an investment of Rs.100,000 at an interest rate of 4% returned a future value of Rs.300,000.

A user wishes to calculate the initial investment (present value) that will return a known future value given a known interest rate and investment period (time).

1. For the purpose of this application all payments and compound interest and be considered to be monthly. So, for example 60 payments is equivalent to 5 years.
2. If the app is backgrounded or closed by the user or runtime, all user data will be preserved persistently and the entry text fields repopulated with the last data used when the app is started or foregrounded.
3. Compounds are monthly payments from the interest on a on savings or are the monthly interest charges on a loan.

E.g. A user wished to know how much to initially invest to get a future value of Rs.300,000 on a savings account with an interest rate of 4% over a 5-year period.
E.g. A user wished to know how much to initially invest to get a future value of Rs.500,000 on a savings account with an interest rate of 4% over a 5-year period where they make monthly payments into their savings account of Rs.10,000.

Note that loans are very similar to the above, for example, a user wished to borrow Rs.300,000, they can afford to pay Rs.35,000 a month, how many
monthly payments (remember this is the same as time) would they need to make if the best loan interest rate they could get was 7%?

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Your Name - [@Mechacoder](https://twitter.com/Mechacoder)

Project Link: [https://github.com/SAM-ITH/FitnessTracker](https://github.com/SAM-ITH/FitnessTracker)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/SAM-ITH/FitnessTracker.svg?style=for-the-badge
[contributors-url]: https://github.com/SAM-ITH/FitnessTracker/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/SAM-ITH/FitnessTracker.svg?style=for-the-badge
[forks-url]: https://github.com/SAM-ITH/FitnessTracker/network/members
[stars-shield]: https://img.shields.io/github/stars/SAM-ITH/FitnessTracker.svg?style=for-the-badge
[stars-url]: https://github.com/SAM-ITH/FitnessTracker/stargazers
[issues-shield]: https://img.shields.io/github/issues/SAM-ITH/FitnessTracker.svg?style=for-the-badge
[issues-url]: https://github.com/SAM-ITH/FitnessTracker/issues
[license-shield]: https://img.shields.io/github/license/SAM-ITH/FitnessTracker.svg?style=for-the-badge
[license-url]: https://github.com/SAM-ITH/FitnessTracker/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/samithwijesighe
[product-screenshot]: images/screenshot.png
[domainmodel-image]: images/domainmodel.png
