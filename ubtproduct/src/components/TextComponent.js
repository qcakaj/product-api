import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import TextField from '@material-ui/core/TextField';

const useStyles = makeStyles((theme) => ({
  root: {
    '& > *': {
      margin: theme.spacing(1),
      width: '37ch',
    },
  },
}));

export default function TextComponent(props) {
  const classes = useStyles();
  return (
    <form className={classes.root} noValidate autoComplete="off">
      <TextField id="filled-basic" label={props.productLabel} variant="filled" onChange={props.handleChange} />
    </form>
  );
}