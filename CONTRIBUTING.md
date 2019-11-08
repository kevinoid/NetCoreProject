Contributing Guidelines
=======================

Thanks for your interest in contributing to this project!  Contributions are
appreciated.  If this is your first time contributing to a Free and Open
Source Software project, consider reading [How to Contribute to Open Source]
in the Open Source Guides.

This project follows the [Contributor Covenant Code of
Conduct](https://www.contributor-covenant.org/version/1/4/code-of-conduct.html).
By participating in this project, you agree to abide by its terms.

Additionally, if you are contributing code, to maximize the chance that your
contribution will be accepted and minimize wasted effort, consider the
following guidelines:


Consider Discussing Big Changes First
-------------------------------------

If the desired change is large, complex, backwards-incompatible, can have
significantly differing implementations, or may not be in scope for this
project, opening an issue to discuss the change before writing the code can
avoid frustration and save a lot of time and effort.

This is not a hard requirement.  If you'd rather start discussing a big change
with a proposed implementation, feel free.  Be aware that the code may be
rejected outright, may duplicate another ongoing effort, or require many
changes before it is acceptable.


Tests Must Pass
---------------

In order for a pull request to be accepted, it must build and test successfully
on the continuous integration systems.  GitHub displays a build status
indicator on the pull request.  If the build is broken, please fix it (or add a
comment if you think the pull request is not the cause of the breakage).

Disabling warnings using inline configuration is acceptable, where
justified.  Disable specific rules where possible (i.e.  `#pragma warning
disable 168, 3021` rather than just `#pragma warning disable`).


Add Tests Where Reasonable
--------------------------

If the pull request fixes a bug or adds a feature, consider adding a test to
ensure the bug does not reoccur and the feature works as expected.  If testing
is not straightforward, feel free to submit the pull request without tests.
How to test and whether testing is required can be discussed during the review
process.

[How to Contribute to Open Source]: https://opensource.guide/how-to-contribute/
