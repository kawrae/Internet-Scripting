DROP TABLE IF EXISTS films;

CREATE TABLE Films(
    FilmID INTEGER PRIMARY KEY,
    Title VARCHAR(50),
    Year INTEGER
);

INSERT INTO
    Films (Title, Year)
VALUES
    ('Casino Royale', 2006),
    ('Diamonds are Forver', 1971),
    ('Die Another Day', 2002),
    ('Dr. No', 1962),
    ('For Your Eyes Only', 1981),
    ('From Russia With Love', 1963),
    ('GoldenEye', 1995),
    ('GoldFinger', 1964),
    ('License To Kill', 1989),
    ('Live And Let Die', 1973),
    ('Living Daylights', 1987),
    ('Man with the Golden Gun', 1974),
    ('Moonraker', 1979),
    ('No Time to Die', 2021),
    ('Octopussy', 1983),
    ('On Her Majesty''s Secret Service', 1969),
    ('Quantum of Solace', 2008),
    ('Skyfall', 2012),
    ('Spectre', 2015),
    ('Spy Who Loved Me', 1977),
    ('Thunderball', 1965),
    ('Tomorrow Never Dies', 1997),
    ('View to a Kill', 1985),
    ('World is Not Enough', 1999),
    ('You Only Live Twice', 1967);