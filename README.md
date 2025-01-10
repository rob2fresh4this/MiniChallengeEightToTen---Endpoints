# MiniChallengeEightToTen - Endpoints

## Overview
Design an API based on mini challenges from the Combine. Each feature must have its own service file, stored inside a `Service` folder. Data validation is required for all endpoints.

## Endpoints

### 1. Magic 8 Ball
**Description:**
Create an endpoint that generates 8 unique responses. 

**Specifications:**
- One controller handles this functionality.
- The endpoint should return a rsponse with 8 distinct answers randomly picked from a predefined set of responses.

---

### 2. Guess It
**Description:**
Create 3 endpoints (handled by one controller) to check if a user’s input is higher or lower than a randomly generated number.

**Modes:**
- **Easy Mode:** Range 1-10
- **Medium Mode:** Range 1-50
- **Hard Mode:** Range 1-100

**Specifications:**
- Validate that the input is within the specified range for the selected mode.
- The endpoint should return a indicating if the guessed number is too high, too low, or correct.

---

### 3. Restaurant Picker
**Description:**
Create an endpoint that takes a category as input and randomly selects a restaurant from a predefined list of 10 restaurants per category.

**Specifications:**
- The endpoint should return containing the selected restaurant’s details.

---

## Deliverables

1. **Project Files**
   - Submit a zipped version of the project.

2. **GitHub Link**
   - Include the repository link in the comments section of your submission.

3. **Peer Review**
   - Ensure you complete the peer review as part of the submission process.

**Note:** Do not host this project on Vercel.


---


#### Your Names:  Robert G.

#### Date Revised  
- [1/8/25]  

#### Exercise or Lab Name  
[MiniChallengeEightToTen]

#### Revision History  
- [1/9/25] done  

# Review by: David Monterrosa


### Overall Feedback: Your GuessIt does not have three different endpoints. Each endpoint will appear in swagger. So you should be using 3 "[HttpGet]" and "[Route("Example/{parameter}")]". Magic 8 Ball and Restaurant Picker appear to work correctly. Great job with validation.
