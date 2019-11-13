Instruction for setup of applicsation:
1. Open BlogPostScript file and first run just create Database command.
2. Run all other commands from BlogPostScript .
3. Clone repository from link: https://github.com/yusuf-usmani/BlogPostApplication.git
4. Change the connection string in BlogPostApp web Application to point user DB server.
5. Change the connection string in BOL class libtrary project to point user DB server.
4. Run the application

About Application:
Its a blog post application which have unsigned anonymous user and signed in user.
Signed in user can be in editor or Admin role.
I have created one admin user as below: 
UserName:  admin@admin.com 
Pwd: ADMIN

User with ADMIN(A) role can Create,Edit,Approve,Reject Blog.
User with ADMIN(A) role can see list of User.

User with Editor(E) role can create,edit blog.

Anonymous user can visit home page and see Blog post list which are in Published state.
