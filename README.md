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
4. At this point, Unity generates an index.html file but it kind of sucks. I recommend grabbing the index.html and styles.css from: (TODO)
6. After the build completes your game will open in Chrome.

## Let the World See Your Game

1. Git push
2. After you build and push up the repo, use the gitub UI to turn on "Pages". 
3. You should see the progress of your deployment in github's UI. As an example: https://github.com/EvanDaley/unity-webgpu-template/actions/runs/10894713366
4. Once that is done, find your game at: https://{your-github-username}.github.io/{your-repo-name}

## Live Demo

Examples:
- https://evandaley.github.io/unity-webgpu-template
- https://evandaley.github.io/WebGPU-URP-Unity6-sandbox
