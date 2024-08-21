# briancuppen.github.io

# Project structure (frontend)

/webstore-project
├── /src
│   ├── /assets
│   │   ├── /images              # Product images, icons, and other media assets
│   │   ├── /fonts               # Custom fonts and typography
│   │   └── /styles              # Global styles, variables, mixins
│   │       └── main.css         # Main stylesheet
│   ├── /components              # Reusable UI components (header, footer, buttons, etc.)
│   │   ├── Header.js
│   │   ├── Footer.js
│   │   └── ProductCard.js
│   ├── /pages                   # Page-specific components
│   │   ├── Home.js              # Home page
│   │   ├── Product.js           # Product detail page
│   │   └── Cart.js              # Shopping cart page
│   ├── /utils                   # Utility functions (helpers, API calls, etc.)
│   │   └── api.js               # API interaction logic
│   ├── /services                # Business logic and service functions
│   │   └── productService.js    # Service for managing products
│   ├── index.html               # Main HTML file
│   ├── index.js                 # Main JavaScript file
│   └── App.js                   # Main application component
│
├── /public                      # Public assets (accessible to users)
│   ├── favicon.ico              # Favicon for the website
│   ├── manifest.json            # Web app manifest (for PWA)
│   └── robots.txt               # SEO-related file for search engines
│
├── /config                      # Configuration files
│   ├── webpack.config.js        # Webpack configuration (if using Webpack)
│   └── .env                     # Environment variables
│
├── /tests                       # Unit and integration tests
│   ├── /components              # Component-specific tests
│   └── /services                # Service-specific tests
│
├── package.json                 # NPM package configuration
├── README.md                    # Documentation for the project
└── .gitignore                   # Files and directories to ignore in Git
