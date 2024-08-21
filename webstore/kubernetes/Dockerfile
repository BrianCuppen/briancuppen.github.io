#make a standard nginx image
FROM nginx:alpine
#copy the build output to replace the default nginx contents.
COPY /dist/webstore /usr/share/nginx/html
#expose the port
EXPOSE 80
#run the nginx server
CMD ["nginx", "-g", "daemon off;"]