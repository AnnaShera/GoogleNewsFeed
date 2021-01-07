# GoogleNewsFeed
Web application that displays topics from Google News RSS feed.

The screen divided into two halves:
* The left section displays all the topics of the RSS feed.
* The right section - title, body, and link. this section is displayed when a user clicks on a topic from the left section.

Request to the RSS feed is made only once and stored in HttpCache.

Upon clicking a topic - an Ajax call is made to the server to retrieve and display the feed's content.
