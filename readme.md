# sm64.net

This repo is a work-in-progress effort aimed towards:
- capturing the full domain of Super Mario 64
- capturing the core ideas behind Super Mario 64 speedrunning
- creating a central data store for Super Mario 64 "routes," including links to various demonstrations, metadata, etc.
- allowing user input from speedrunners and TASers[1], such as speedrunning logs, PBs, 
- utilizing the above data to make "train" the speedrunner (e.g. make recommendations on which Segment (e.g. star) to train)
- discover new potential routes, utilizing graph computation and weighing risk[2]
- enabling collaboration between the English-speaking and Japanese communities[3]
- integration into other related speedrunning services such as LiveSplit

[1] TAS = Tool-Assisted Speedrunning, a variant of "normal" speedrunning.

[2] Where 2 strategies exist for one "segment," one may be faster but also more difficult to pull off. 

[3] It seems that these communities have been somewhat lacking in cross-language technical communication; I think there's an opportunity to fix that here.

I'm streaming the development of this repo [on Twitch](https://twitch.tv/stachudotnet).

## Contributing

If you have time/energy to contribute, feel free to message below and we can chat about collaboration. (non-programmers, fear not!)  

You can find me on [Twitter](https://twitter.com/stachudotnet), [Twitch](https://twitch.tv/stachudotnet), or StachuDotNet#9760 on Discord.
I'd be happy to pair on improvements, content-enhancements, etc.

## Tech Stuff

- backend: F# language and Giraffe web framework
- frontend: Bulma for styling, and HTML powered by Giraffe on server side
- Docker, AWS (ECR, ECS) for hosting, and GitHub Actions for CI/CD
- Expecto for testing

I develop in Jetbrains Rider, but VS Code or Visual Studio should also run things fine.