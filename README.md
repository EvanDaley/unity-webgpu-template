# unity-webgpu-template

## Summary

This template is intended to simplify the process of creating Unity 6 projects that utilize WebGPU.

## Primary Features
- This setup work is already complete: https://discussions.unity.com/t/early-access-to-the-new-webgpu-backend-in-unity-2023-3/933493
- An example build
- Easy deployment with github pages. 
- Improved CSS and HTML sizing
- A better page loading experience than you would get with a default Unity 6 deployment

## Local Development

1. Create a repo from this template
2. Open the project in Unity 6
3. File -> Build and Run. Build to the "Build" folder
4. At this point, Unity creates an index.html file under the Builds folder but it sucks, and you don't want to use it. Delete that shit.
5. Use the index.html file provided in this repo, at the root of the directory.
6. After the build completes Unity will have opened your game in Chrome. Close that tab.
7. Instead, you want to hit "Go Live" in the bottom right hand corner of VS Code. This will server the site using the correct root HTML file, and it'll still work even if Unity isn't running.

## Let the World See Your Game

1. Git push
2. After you build and push up the repo, use the gitub UI to turn on "Pages". 
3. Then find your game at: https://{your-github-username}.github.io/{your-repo-name}


