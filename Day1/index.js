document.addEventListener("DOMContentLoaded", () => {
    const generateBtn = document.getElementById("generateBtn");
    const optionsSelect = document.getElementById("options");
    const keywordInput = document.getElementById("keyword");
    const outputText = document.getElementById("outputText");

    generateBtn.addEventListener("click", async () => {
        const option = optionsSelect.value;
        const keyword = keywordInput.value;
        var message = "Generate a "+option+ " throught a keyword : "+keyword;

        if (!option || !keyword) {
            alert("Please select an option and enter a keyword.");
            return;
        }

        const content = await generateContent(message);

        outputText.textContent = content;
    });


    async function generateContent(message) {
        try {
            const response = await fetch('https://api.openai.com/v1/chat/completions', {
                method: 'POST',
                headers: {
                    "Content-Type": "application/json",
                    Authorization: 'Bearer ${API_KEY}'
                },
                body: JSON.stringify({
                    model: "gpt-3.5-turbo",
                    messages: [{ role: "user", content: message }],
                    max_tokens: 200,
                }),
            });

            if (!response.ok) {
                throw new Error('Something Went Wrong !!!');
            }
            console.log(response);
            const data = await response.json();
            return data.choices[0].message.content;
        } catch (error) {
            console.error('Error generating content:', error);
            return 'Error generating content';
        }
    }
});
