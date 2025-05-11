# ImageProcessing
## Overview
This is a RESTful API that allows users to upload images and apply filters (grayscale, sepia, etc.) with features like rate limiting, caching, and API key authentication.

## Features
* Image processing with filters (grayscale, sepia)
* API key authentication
* Rate limiting to prevent abuse
* Caching for improved performance
* Simple API key management

API Endpoints
1. Image Processing
POST /api/images/process
Processes an uploaded image with the specified filter
2. API Key Generation
POST /api/apikeys/generate
Generates a new API key for authentication.

## Rate Limiting
* The API implements rate limiting:
* Default limit: 10 requests per minute per API key
* Exceeding the limit returns HTTP 429 Too Many Requests

## Caching
* Processed images are cached based on original content and filter parameters
* Subsequent identical requests return cached results for improved performance
## Configuration
* Configuration options can be set in appsettings.json:
* Rate limiting parameters
