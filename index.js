import express from 'express';
import db from './data/data.js';
import cors from 'cors';

const app = express();
const PORT = 3033;
app.use(express.json());
app.use(cors('*'));
app.listen(PORT, () => console.log(`Running at http://localhost:${PORT}`));

app.get('/fours', (_, res) => {
    const fours = db.prepare(`SELECT * FROM fours`).all();
    res.status(200).send(fours);
});
app.get('/fours/:id', (req, res) => {
    const id = +req.params.id;
    const fours = db.prepare(`SELECT * FROM fours WHERE id = ?`).get(id);
    res.status(200).send(fours);
});
app.post('/fours', (req, res) => {
    const { fours } = req.body;
    if (fours.length !== 4) return res.status(400).send({ message: 'Invalid data' });
    fours.forEach((element) => {
        if (isNaN(element)) return res.status(400).send({ message: 'Invalid data' });
        else if (element < 0) return res.status(400).send({ message: 'Invalid data' });
    });
    try {
        db.prepare(`INSERT INTO fours (numbers) VALUES (?)`).run(JSON.stringify(fours));
        return res.status(201).send({ message: 'Created' });
    } catch (_) {
        return res.status(409).send({ message: 'Conflict' });
    }
});
