# TutorialOnEventsAndDelegates

This is an extended project that was covered in this tutorial by "Programming with Mosh": 
https://www.youtube.com/watch?v=jQgwEsJISy0&list=PLTjRvDozrdlz3_FPXwb6lX_HoGXa09Yef&index=11

What was introduced:
  - genericity of EventArgs custom class, insted of creating specific class like VideoEventArgs, I created the generic class ObjectEventArgs<T> and then implemented it to work in this project as well as was specific class VideoEventArgs
  - The master class called MediaService that contains inside other Service classes like MessageService, or MailService. I've done this, to be able to attach at once all of Media Services having OnVideoEdited trigger without having to add "videoEncoder.VideoEncoded += someMediaService.OnVideoEncoded" every single time we're adding a new event subscriber
  
! However, the way I've done it is by making MediaService a partial class and creating every other service inside of it (but in seperate files). I've trided to use inheritance of MediaService, as in Program.cs in method AttachMediaServicesToVideoEncodedEventHandler I'm trying to add all services automatically and I do so by invoking .GetType().GetNestedTypes() on MediaService member, but I can't find a function that would be able to return all objects that inherit from MediaService.
