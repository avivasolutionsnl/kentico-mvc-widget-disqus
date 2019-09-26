# Kentico MVC Disqus Widget
This repository contains the Kentico MVC Disqus widget.
It can be added to your project by installing the nuget package. The source code will be added to your project so you can easily add your own project specific changes.

## Settings
For more information about the settings visit [this](https://help.disqus.com/en/articles/1717084-javascript-configuration-variables) link. 

### Shortname
The shortname is used by disqus to identify your disqus forum. It's the part of the url in front of '.disqus.com'

### Page URL
The page URL tells disqus the current URL the widget is on. If it is undefined it will use the 'window.location.href'. The Page URL is used if the page identifier is undefined. This is also saved when a thread is created so that Disqus knows to which URL the thread belongs. If the page URL is incorrect the widget will not be shown.

### Page Identifier
The page identifier tells Disqus how to identify the current page. When the Disqus widget is load this will be used to lookup the thread. If undefined the current URL is used.

### Page Title
The page Title tells Disqus the title of the current page. This is used when the thread is created for the first time. If undefined Disqus uses the '<title>' tag of the current page. If that cannot be used the page URL will be used.

### Page Category
Tells Disqus the category of the current thread. This is used when the thread is created for the first time. Categories can be created with the Disqus API. If the category is not correct the widget will not be shown.

## License
The MIT license is used with this product.

## Issues
If you have issues with the widget you can submit an issue or pull request. There is no active support on this widget.

