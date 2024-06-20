import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const PORT = 3000;
const DB_FILE_PATH = path.join(__dirname, 'db.json');

app.use(bodyParser.json());

// Endpoint to check if server is running
app.get('/ping', (req: Request, res: Response) => {
    res.send(true);
});

// Endpoint to submit data
app.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;

    if (!name || !email || !phone || !github_link || !stopwatch_time) {
        return res.status(400).send('All fields are required.');
    }

    const submission = {
        name,
        email,
        phone,
        github_link,
        stopwatch_time
    };

    const data = JSON.parse(fs.readFileSync(DB_FILE_PATH, 'utf-8'));
    data.submissions.push(submission);
    fs.writeFileSync(DB_FILE_PATH, JSON.stringify(data, null, 2));

    res.status(201).send('Submission saved successfully.');
});

// Endpoint to read a submission by index
app.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);

    if (isNaN(index)) {
        return res.status(400).send('Index must be a number.');
    }

    const data = JSON.parse(fs.readFileSync(DB_FILE_PATH, 'utf-8'));

    if (index < 0 || index >= data.submissions.length) {
        return res.status(404).send('Submission not found.');
    }

    res.json(data.submissions[index]);
});

// Route handler for the root URL
app.get('/', (req: Request, res: Response) => {
    res.send('Welcome to the Express TypeScript backend!');
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
