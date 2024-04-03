let isSpinning = false; // Flag to track spinning state
let numbers = [0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26];
let selectedNumber; // Variable to store the selected number
let frameId; // Id of the animation frame

// Start spinning function

export function startSpinning() {
    if (!isSpinning) {
        selectedNumber = numbers[Math.floor(Math.random() * numbers.length)];
        isSpinning = true;
        startTime = null;
        drawRouletteWheel();
        draw(performance.now());
    }
}
export function drawRouletteWheel() {
    const canvas = document.getElementById('wheel');
    const ctx = canvas.getContext('2d');
    const centerX = canvas.width / 2;
    const centerY = canvas.height / 2;
    const radius = 180;
    const numSections = 36; // Number of sections on the wheel
    let rotationAngle = 0; // Initial rotation angle
    let startTime; // Time when spinning started

    function draw(timestamp) {
        if (!startTime) {
            startTime = timestamp;
        }

        // Clear the canvas
        ctx.clearRect(0, 0, canvas.width, canvas.height);

        // Draw the wheel
        ctx.beginPath();
        ctx.arc(centerX, centerY, radius, 0, Math.PI * 2);
        ctx.fillStyle = 'green';
        ctx.fill();
        ctx.closePath();

        // Draw the sections and numbers
        for (let i = 0; i < numSections; i++) {
            const startAngle = (i - 0.5) * (Math.PI * 2 / numSections) + rotationAngle;
            const endAngle = (i + 0.5) * (Math.PI * 2 / numSections) + rotationAngle;
            const startX = centerX + Math.cos(startAngle) * radius;
            const startY = centerY + Math.sin(startAngle) * radius;
            const endX = centerX + Math.cos(endAngle) * radius;
            const endY = centerY + Math.sin(endAngle) * radius;
            const number = numbers[i]; // Get the number from the array

            ctx.beginPath();
            ctx.moveTo(startX, startY);
            ctx.lineTo(endX, endY);
            ctx.strokeStyle = 'white';
            ctx.stroke();
            ctx.closePath();

            ctx.fillStyle = 'white';
            ctx.font = '12px Arial';
            ctx.textAlign = 'center';
            ctx.fillText(number, centerX + Math.cos((startAngle + endAngle) / 2) * radius * 0.75, centerY + Math.sin((startAngle + endAngle) / 2) * radius * 0.75);
        }

        // Calculate time elapsed
        const elapsedTime = timestamp - startTime;

        // Check if 5 seconds have passed
        if (elapsedTime < 5000) {
            // Continue spinning
            frameId = requestAnimationFrame(draw);
        } else {
            // Stop spinning
            cancelAnimationFrame(frameId);
            isSpinning = false;
            startTime = null;
        }

        // Increment rotation angle for animation if spinning
        if (isSpinning) {
            rotationAngle += 0.05; // Adjust rotation speed here
        }
    }

    // Start spinning on click
    canvas.addEventListener('click', () => {
        if (!isSpinning) {
            // Randomly select a number
            selectedNumber = numbers[Math.floor(Math.random() * numbers.length)];
            isSpinning = true; // Start spinning
            startTime = null; // Reset startTime
            draw(performance.now()); // Start animation
        }
    });

    // Initial drawing
    draw();
}
