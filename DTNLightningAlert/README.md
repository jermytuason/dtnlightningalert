# DTN Lightning Alert Application Instructions

## Steps on how to use:

- Run the solution using Visual Studio
- Input the file path for Lightning Data JSON file. 
- Input the file path for Assets Data JSON file. 
    - NOTE FOR FILE PATH INPUTS: If you input null, blank or invalid file path system will not crash but it will prompt you again and again until you input a correct and valid file path.
                                This is to make the system dynamic and can read anyfile
- Let the system process the data.
- After the system process the data, the alerts will be shown in the command prompt.
- System will let you choose to run the process again. Please type 'Y' if you want to Continue and repeat the process again and choose another files, else press any key to Quit.

### Answer to the additional Questions:
- What is the [time complexity](https://en.wikipedia.org/wiki/Time_complexity) for determining if a strike has occurred for a particular asset?
- If we put this code into production, but found it too slow, or it needed to scale to many more users or more frequent strikes, what are the first things you would think of to speed it up?
    - First and foremost if it's slow in production we might need to look back in the code and refactor the logic that we know might be expensive in processing, 
      aside from that we can lessen the fields in the Lightning Data File as there are a lot of fields that are not being use as of now. 
      We can lessen the time of deserializing the json file to an object if we'll remove unnecessary fields. We can also consider auto scaling in the Production Environment especially if there are 
      too many users that are simultaneously using the system or to frequent strikes are happening.