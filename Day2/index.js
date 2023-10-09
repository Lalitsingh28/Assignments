let editor;
let monacoLoaded = false;

let editor_lang = document.getElementById('language-editor').value;

function loadMonacoEditor() {
    if (!monacoLoaded) {
        require.config({ paths: { 'vs': 'https://cdnjs.cloudflare.com/ajax/libs/monaco-editor/0.29.0/min/vs' } });
        require(['vs/editor/editor.main'], function () {
            monacoLoaded = true;
            editor = monaco.editor.create(document.getElementById('editor'), {
                value: '',
                language: editor_lang,
                theme: 'vs-dark',
                automaticLayout: true,
            });
        });
    }
}

// Function to handle code conversion
async function convertCode() {
    const inputCode = editor.getValue();
    const selectedLanguage = document.getElementById("language-select").value;
    // console.log(selectedLanguage);

    try {
        const response = await fetch('https://api.openai.com/v1/chat/completions', {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
                Authorization: 'Bearer ${API_KEY}'
            },
            body: JSON.stringify({
                model: "gpt-3.5-turbo",
                messages: [{ role: "user", content: "Convert "+inputCode+ " code into "+selectedLanguage+" language code" }],
                max_tokens: 200,
            }),
        });

        if (!response.ok) {
            throw new Error('Something Went Wrong !!!');
        }
        // console.log(response);
        const data = await response.json();
        displayResult(data.choices[0].message.content);
    } catch (error) {
        console.error('Error generating content:', error);
        return 'Error generating content';
    }
    
}

// Function to handle debugging
 async function debugCode() {
    const inputCode = editor.getValue();
    
    try {
        const response = await fetch('https://api.openai.com/v1/chat/completions', {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
                Authorization: 'Bearer ${API_KEY}'
            },
            body: JSON.stringify({
                model: "gpt-3.5-turbo",
                messages: [{ role: "user", content: "Debut this given code : "+inputCode }],
                max_tokens: 200,
            }),
        });

        if (!response.ok) {
            throw new Error('Something Went Wrong !!!');
        }
        // console.log(response);
        const data = await response.json();
        displayResult(data.choices[0].message.content);
    } catch (error) {
        console.error('Error generating content:', error);
        return 'Error generating content';
    }
}

// Function to check code quality
async function checkCodeQuality() {
    const inputCode = editor.getValue();
    
    try {
        const response = await fetch('https://api.openai.com/v1/chat/completions', {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
                Authorization: 'Bearer ${API_KEY}',
            },
            body: JSON.stringify({
                model: "gpt-3.5-turbo",
                messages: [{ role: "user", content: 'Please provide a code quality assessment for the given code '+ inputCode+'. Consider the following parameters: '+
                +'1. Code Consistency: Evaluate the code for consistent coding style, naming conventions, and formatting.'
                +'2. Code Performance: Assess the code for efficient algorithms, optimized data structures, and overall performance considerations.'
                +'3. Code Documentation: Review the code for appropriate comments, inline documentation, and clear explanations of complex logic.'
                +'4. Error Handling: Examine the code for proper error handling and graceful error recovery mechanisms.'
                +'5. Code Testability: Evaluate the code for ease of unit testing, mocking, and overall testability.'
                +'6. Code Modularity: Assess the code for modular design, separation of concerns, and reusability of components.'
                +'7. Code Complexity: Analyze the code for excessive complexity, convoluted logic, and potential code smells.'
                +'8. Code Duplication: Identify any code duplication and assess its impact on maintainability and readability.'
                +'9. Code Readability: Evaluate the code for readability, clarity, and adherence to coding best practices.'
                +'Please provide a summary of the code quality assessment and a report showing the percentage-wise evaluation for each parameter mentioned above.' }],
                max_tokens: 500,
            }),
        });

        if (!response.ok) {
            throw new Error('Something Went Wrong !!!');
        }
        // console.log(response);
        const data = await response.json();
        displayResult(data.choices[0].message.content);
    } catch (error) {
        console.error('Error generating content:', error);
        return 'Error generating content';
    }
    
}

// Function to display results
function displayResult(result) {
    const results = document.getElementById("results");
    results.innerText = result;
}

window.onload = loadMonacoEditor;
